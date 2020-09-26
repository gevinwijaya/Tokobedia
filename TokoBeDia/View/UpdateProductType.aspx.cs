using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class UpdateProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_ProductTypes();
            warningDescription.Visible = false;
            warningProductTypeId.Visible = false;
            warningProductTypeName.Visible = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            bool passRequirements = true;
            int producttypeid = Convert.ToInt32(txtProductTypeId.Text);
            ProductType pt2 = ProductTypeRepository.FindProductTypeById(producttypeid);
            String producttypename = txtProductTypeName.Text;
            ProductType pt = ProductTypeRepository.FindProductTypeByName(producttypename);
            if(txtProductTypeId.Text == "" || pt2 == null)
            {
                warningProductTypeId.Visible = true;
                passRequirements = false;
            }
            if (txtProductTypeName.Text == "" || producttypename.Length < 5 || pt != null)
            {
                passRequirements = false;
                warningProductTypeName.Visible = true;
            }
            if (txtDescription.Text == "")
            {
                passRequirements = false;
                warningDescription.Visible = true;
            }
            if (passRequirements == true)
            {
                String description = txtDescription.Text;
                
                ProductTypeRepository.Update(producttypeid,producttypename,description);

                Response.Redirect("Home.aspx");

            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
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
    }
}