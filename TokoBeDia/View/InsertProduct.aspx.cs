using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Factory;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_ProductTypes();
            warningProductTypeId.Visible = false;
            warningProductName.Visible = false;
            warningStock.Visible = false;
            warningPrice.Visible = false;
        }

        protected void Load_ProductTypes()
        {
            List<TokoBeDia.ProductType> producttypelist = ProductTypeRepository.GetAll();
            for (int i = 0; i < producttypelist.Count; i++)
            {
                TableRow newRow = new TableRow();
                ProductType.Controls.Add(newRow);

                TableCell numberCell = new TableCell();
                numberCell.Controls.Add(new Label()
                {
                    Text = (i + 1) + "."
                });
                newRow.Cells.Add(numberCell);

                TableCell productTypeIdCell = new TableCell();
                productTypeIdCell.Controls.Add(new Label()
                {
                    Text = producttypelist.ElementAt(i).ProductTypeId.ToString()
                });
                newRow.Cells.Add(productTypeIdCell);

                TableCell productTypeNameCell = new TableCell();
                productTypeNameCell.Controls.Add(new Label()
                {
                    Text = producttypelist.ElementAt(i).Name.ToString()
                });
                newRow.Cells.Add(productTypeNameCell);

                TableCell descriptionCell = new TableCell();
                descriptionCell.Controls.Add(new Label()
                {
                    Text = producttypelist.ElementAt(i).Description.ToString()
                });
                newRow.Cells.Add(descriptionCell);


            }


        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            bool passRequirements = true;
            int producttypeid = Convert.ToInt32(txtProductTypeId.Text);
            ProductType pt = ProductTypeRepository.FindProductTypeById(producttypeid);
            int price = Convert.ToInt32(txtPrice.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            if (txtProductTypeId.Text == "" || pt == null)
            {
                passRequirements = false;
                warningProductTypeId.Visible = true;
            }
            if (txtProductName.Text == "")
            {
                passRequirements = false;
                warningProductName.Visible = true;
            }
            if (txtPrice.Text == "" || price<1000 || price%1000!=0)
            {
                passRequirements = false;
                warningPrice.Visible = true;
            }
            if (txtStock.Text == "" || stock<1)
            {
                passRequirements = false;
                warningStock.Visible = true;
            }
            if(passRequirements == true)
            {
                
                String productname = txtProductName.Text;
                

                Product newProduct = ProductFactory.CreateProduct(producttypeid, productname, price, stock);
                ProductRepository.Create(newProduct);

                Response.Redirect("Home.aspx");

            }
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}