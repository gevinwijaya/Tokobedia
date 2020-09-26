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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            warningRole.Visible = false;
            warningUsername.Visible = false;
            warningPassword.Visible = false;
            warningConfirmPassword.Visible = false;
            warningEmail.Visible = false;
            warningGender.Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            bool PassRequirements = true;
            
            if(radioRole.SelectedValue == null)
            {
                PassRequirements = false;
                warningRole.Visible = true;
            }
            if (txtUsername.Text == "")
            {
                PassRequirements = false;
                warningUsername.Visible = true;
            }
            if(txtPassword.Text == "")
            {
                PassRequirements = false;
                warningPassword.Visible = true;
            }
            if(txtConfirmPassword.Text == "" || txtConfirmPassword.Text != txtPassword.Text)
            {
                PassRequirements = false;
                warningConfirmPassword.Visible = true;
            }
            if(txtEmail.Text == "" || UserRepository.FindUser(txtEmail.Text)!=null)
            {
                PassRequirements = false;
                warningEmail.Visible = true;
            }
            if (radioGender.SelectedValue == null)
            {
                PassRequirements = false;
                warningRole.Visible = true;
            }
            if(PassRequirements == true)
            {
                int roleid = 0;
                if (radioRole.SelectedItem.Value.ToString() == "1")
                {
                    roleid = 1;
                }
                else
                {
                    roleid = 2;
                }
                String username = txtUsername.Text;
                String email = txtEmail.Text;
                String password = txtPassword.Text;
                String gender = radioGender.SelectedItem.Value.ToString();
                String status = "Active";

                User newUser = UserFactory.CreateUser(roleid, username, email, password, gender, status);
                UserRepository.Create(newUser);

                Response.Redirect("Home.aspx");
            }
            
 

        }
    }
}