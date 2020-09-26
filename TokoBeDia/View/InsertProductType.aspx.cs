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
    public partial class InsertProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            warningProductTypeName.Visible = false;
            warningDescription.Visible = false;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            bool passRequirements = true;
            String producttypename = txtProductTypeName.Text;
            ProductType pt = ProductTypeRepository.FindProductTypeByName(producttypename);
            if (txtProductTypeName.Text == "" || producttypename.Length < 5 || pt!=null)
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

                ProductType newProductType = ProductTypeFactory.CreateProductType(producttypename, description);
                ProductTypeRepository.Create(newProductType);

                Response.Redirect("Home.aspx");

            }
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}