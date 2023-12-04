using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                try
                {
                    string directorioDestino = Server.MapPath("~/Imagenes/");

                    if (!Directory.Exists(directorioDestino))
                    {
                        Directory.CreateDirectory(directorioDestino);
                    }

                    string nombreImagen = Path.GetFileName(fileUpload.FileName);

                    fileUpload.SaveAs(Path.Combine(directorioDestino, nombreImagen));

                    imgMostrar.ImageUrl = "~/Imagenes/" + nombreImagen;
                    imgMostrar.Visible = true;
                    ScriptManager.RegisterStartupScript(this, GetType(), "successAlert", "Swal.fire('Éxito', 'La imagen se ha guardado correctamente.', 'success');", true);
                } 
                catch (Exception ex)
                {
                    Response.Write("Error " + ex.Message);
                    ScriptManager.RegisterStartupScript(this, GetType(), "errorAlert", $"Swal.fire('Error', '{ex.Message}', 'error');", true);
                }
            }
            else
            {
                //Response.Write("Por favor, selecciona una imagen para cargar");
                ScriptManager.RegisterStartupScript(this, GetType(), "warningAlert", "Swal.fire('Advertencia', 'Por favor, selecciona una imagen para cargar.', 'warning');", true);
            }
        }
    }
}