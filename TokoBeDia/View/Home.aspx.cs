using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Products();
            btnViewUser.Visible = false;
            btnLogin.Visible = false;
            btnRegister.Visible = false;
            btnLogout.Visible = false;
            btnChangePassword.Visible = false;
            btnProfile.Visible = false;
            btnUpdateProfile.Visible = false;
            btnViewProduct.Visible = false;
            btnInsertProduct.Visible = false;
            btnUpdateProduct.Visible = false;
            btnViewProductType.Visible = false;
            btnInsertProductType.Visible = false;
            btnUpdateProductType.Visible = false;

             
            
            if (Session["auth_user"] == null || Request.Cookies["auth_user"] == null)
            {
                btnLogin.Visible = true;
                btnRegister.Visible = true;
                btnViewProduct.Visible = true;
            }
            else
            {
                User u = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
                if (u.RoleId == 1)
                {
                    btnViewUser.Visible = true;
                    btnViewProduct.Visible = true;
                    btnInsertProduct.Visible = true;
                    btnUpdateProduct.Visible = true;
                    btnViewProductType.Visible = true;
                    btnInsertProductType.Visible = true;
                    btnUpdateProductType.Visible = true;
                    btnProfile.Visible = true;
                    btnUpdateProfile.Visible = true;
                    btnChangePassword.Visible = true;
                    btnLogout.Visible = true;
                }
                else if (u.RoleId == 2)
                {
                    btnViewProduct.Visible = true;
                    btnProfile.Visible = true;
                    btnChangePassword.Visible = true;
                    btnLogout.Visible = true;
                }
            }

            

        }

        protected void Load_Products()
        {
            List<TokoBeDia.Product> productlist = ProductRepository.GetAll();
            Random r = new Random();
            if (productlist.Count != 0)
            {
                int[] taggedIdx = new int[5];
                for(int j = 0; j < 5; j++)
                {
                    taggedIdx[j] = -1;
                }
                for (int i = 0; i < 5; i++)
                {
                    
                    int idx = r.Next(0, productlist.Count - 1);
                    bool alreadyUsed = false;
                    for(int j = 0; j < productlist.Count; j++)
                    {
                        if(taggedIdx[j] != -1 && idx == taggedIdx[j])
                        {
                            alreadyUsed = true;
                        }
                    }
                    if(alreadyUsed == false)
                    {
                        taggedIdx[i] = idx;

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
                            Text = productlist.ElementAt(idx).ProductId.ToString()
                        });
                        newRow.Cells.Add(productIdCell);

                        TableCell productNameCell = new TableCell();
                        productNameCell.Controls.Add(new Label()
                        {
                            Text = productlist.ElementAt(idx).Name.ToString()
                        });
                        newRow.Cells.Add(productNameCell);

                        TableCell productStockCell = new TableCell();
                        productStockCell.Controls.Add(new Label()
                        {
                            Text = productlist.ElementAt(idx).Stock.ToString()
                        });
                        newRow.Cells.Add(productStockCell);

                        TableCell productTypeCell = new TableCell();
                        productTypeCell.Controls.Add(new Label()
                        {
                            Text = productlist.ElementAt(idx).ProductType.Name.ToString()
                        });
                        newRow.Cells.Add(productTypeCell);

                        TableCell productPriceCell = new TableCell();
                        productPriceCell.Controls.Add(new Label()
                        {
                            Text = productlist.ElementAt(idx).Price.ToString()
                        });
                        newRow.Cells.Add(productPriceCell);


                    }
                }
                    
            }
            


        }

        protected void btnViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProduct.aspx");
        }

        protected void btnViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType.aspx");
        }

        protected void btnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }

        protected void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductType.aspx");
        }


    }
}