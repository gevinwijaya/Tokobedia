using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.Repository;

namespace TokoBeDia.View
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Users();
            warningSelf.Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(editUserId.Text);
            User u = UserRepository.FindUserById(userid);
            User u2 = UserRepository.FindUser(Request.Cookies["auth_user"].Value);
            if(u2.UserId == u.UserId)
            {
                warningSelf.Visible = true;
            }
            else
            {
                int roleid = 0;
                if (editRole.SelectedItem.Value.ToString() == "1")
                {
                    roleid = 1;
                }
                else
                {
                    roleid = 2;
                }
                String status = editStatus.SelectedItem.Value.ToString();


                UserRepository.Update(userid, roleid, status);

                Response.Redirect("Home.aspx");
            }
        }


        protected void Load_Users()
        {
            List<TokoBeDia.User> userlist = UserRepository.GetAll();
            for (int i = 0; i < userlist.Count; i++)
            {
                TableRow newRow = new TableRow();
                User.Controls.Add(newRow);

                TableCell numberCell = new TableCell();
                numberCell.Controls.Add(new Label()
                {
                    Text = (i + 1) + "."
                });
                newRow.Cells.Add(numberCell);

                TableCell userIdCell = new TableCell();
                userIdCell.Controls.Add(new Label()
                {
                    Text = userlist.ElementAt(i).UserId.ToString()
                });
                newRow.Cells.Add(userIdCell);

                TableCell roleCell = new TableCell();
                String role = userlist.ElementAt(i).Role.Name.ToString();
                roleCell.Controls.Add(new Label()
                {
                    Text = role
                });
                newRow.Cells.Add(roleCell);

                TableCell nameCell = new TableCell();
                nameCell.Controls.Add(new Label()
                {
                    Text = userlist.ElementAt(i).Name.ToString()
                });
                newRow.Cells.Add(nameCell);

                TableCell emailCell = new TableCell();
                emailCell.Controls.Add(new Label()
                {
                    Text = userlist.ElementAt(i).Email.ToString()
                });
                newRow.Cells.Add(emailCell);

                TableCell genderCell = new TableCell();
                genderCell.Controls.Add(new Label()
                {
                    Text = userlist.ElementAt(i).Gender.ToString()
                });
                newRow.Cells.Add(genderCell);

                TableCell statusCell = new TableCell();
                statusCell.Controls.Add(new Label()
                {
                    Text = userlist.ElementAt(i).Status.ToString()
                });
                newRow.Cells.Add(statusCell);


            }


        }

        

    }

}


