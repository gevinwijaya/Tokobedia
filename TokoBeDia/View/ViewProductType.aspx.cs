using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_ProductTypes();
            warningProductTypeId.Visible = false;
            txtProductTypeId.Visible = false;
            lblProductId.Visible = false;
            btnDeleteProductType.Visible = false;
            btnInsertProductType.Visible = false;
            btnUpdateProductType.Visible = false;

            User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            if (u.RoleId == 1)
            {
                txtProductTypeId.Visible = true;
                lblProductId.Visible = true;
                btnDeleteProductType.Visible = true;
                btnInsertProductType.Visible = true;
                btnUpdateProductType.Visible = true;
            }
        }

        protected void btnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductType.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnDeleteProductType_Click(object sender, EventArgs e)
        {
            int producttypeid = Convert.ToInt32(txtProductTypeId.Text);
            ProductType pt = ProductTypeRepository.FindProductTypeById(producttypeid);
            Product p = ProductRepository.FindProductByType(producttypeid);
            if (pt == null || txtProductTypeId.Text == "" || p != null)
            {
                warningProductTypeId.Visible = true;
            }
            else
            {
                ProductTypeRepository.Delete(producttypeid);
                Response.Redirect("ViewProductType.aspx");
            }
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