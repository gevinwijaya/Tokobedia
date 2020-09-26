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
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Products();
            warningProductId.Visible = false;
            warningProductTypeId.Visible = false;
            warningProductName.Visible = false;
            warningStock.Visible = false;
            warningPrice.Visible = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(txtProductId.Text);
            Product p = ProductRepository.FindProductById(productid);
            bool passRequirements = true;
            int price = Convert.ToInt32(txtPrice.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            if (txtProductId.Text == "" || p == null)
            {
                warningProductId.Visible = true;
            }
            else
            {
                if (txtProductTypeId.Text == "")
                {
                    passRequirements = false;
                    warningProductTypeId.Visible = true;
                }
                if (txtProductName.Text == "")
                {
                    passRequirements = false;
                    warningProductName.Visible = true;
                }
                if (txtPrice.Text == "" || price <1000 || price%1000 != 0)
                {
                    passRequirements = false;
                    warningPrice.Visible = true;
                }
                if (txtStock.Text == "" || stock < 1)
                {
                    passRequirements = false;
                    warningStock.Visible = true;
                }
                if (passRequirements == true)
                {
                    int producttypeid = Convert.ToInt32(txtProductTypeId.Text);
                    String productname = txtProductName.Text;
                    
                    
                    ProductRepository.Update(productid,producttypeid,productname,price,stock);

                    Response.Redirect("Home.aspx");

                }
            }
            
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Load_Products()
        {
            List<TokoBeDia.Product> productlist = ProductRepository.GetAll();
            for (int i = 0; i < productlist.Count; i++)
            {
                TableRow newRow = new TableRow();
                Product.Controls.Add(newRow);

                TableCell numberCell = new TableCell();
                numberCell.Controls.Add(new Label()
                {
                    Text = (i + 1) + "."
                });
                newRow.Cells.Add(numberCell);

                TableCell productIdCell = new TableCell();
                productIdCell.Controls.Add(new Label()
                {
                    Text = productlist.ElementAt(i).ProductId.ToString()
                });
                newRow.Cells.Add(productIdCell);

                TableCell productNameCell = new TableCell();
                productNameCell.Controls.Add(new Label()
                {
                    Text = productlist.ElementAt(i).Name.ToString()
                });
                newRow.Cells.Add(productNameCell);

                TableCell productStockCell = new TableCell();
                productStockCell.Controls.Add(new Label()
                {
                    Text = productlist.ElementAt(i).Stock.ToString()
                });
                newRow.Cells.Add(productStockCell);

                TableCell productTypeCell = new TableCell();
                productTypeCell.Controls.Add(new Label()
                {
                    Text = productlist.ElementAt(i).ProductType.Name.ToString()
                });
                newRow.Cells.Add(productTypeCell);

                TableCell productPriceCell = new TableCell();
                productPriceCell.Controls.Add(new Label()
                {
                    Text = productlist.ElementAt(i).Price.ToString()
                });
                newRow.Cells.Add(productPriceCell);


            }


        }
    }
}