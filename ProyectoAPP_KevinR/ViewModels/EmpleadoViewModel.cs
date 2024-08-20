using ProyectoAPP_KevinR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAPP_KevinR.ViewModels
{
    public class EmpleadoViewModel : BaseViewModel
    {

        

        public Empleado MyEmpleado { get; set; }


        public EmpleadoViewModel()
        {
            MyEmpleado = new Empleado();
        }

        public async Task<bool> VmAddEmpleado(string pName, string pLast_Name, string pPost, int pPhone, string pEmail, string pPassword)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {

                MyEmpleado = new Empleado()
                {
                    Name = pName,
                    Last_name = pLast_Name,
                    Post = pPost,
                    Phone = pPhone,
                    E_mail = pEmail,
                    Password = pPassword,
                    
                };

                bool Ret = await MyEmpleado.AddEmpleadoAsync();

                return Ret;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            { IsBusy = false; }
        }

    }
}
