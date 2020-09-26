using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Products();
            warningProductId.Visible = false;
            btnDeleteProduct.Visible = false;
            btnInsertProduct.Visible = false;
            btnUpdateProduct.Visible = false;
            txtProductId.Visible = false;
            lblProductId.Visible = false;

            
            User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            if (u.RoleId == 1)
            {
                btnDeleteProduct.Visible = true;
                btnInsertProduct.Visible = true;
                btnUpdateProduct.Visible = true;
                txtProductId.Visible = true;
                lblProductId.Visible = true;
            }
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int productid = Convert.ToInt32(txtProductId.Text);
            Product p = ProductRepository.FindProductById(productid);
            if (p == null || txtProductId.Text == "")
            {
                warningProductId.Visible = true;
            }
            else
            {
                ProductRepository.Delete(productid);
                Response.Redirect("ViewProduct.aspx");
            }
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