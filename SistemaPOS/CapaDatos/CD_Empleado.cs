﻿using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Empleado
    {
        public void agregarEmpleado(Int64 pDni, string pApellido, string pNombre, string pEmail, string pDireccion, long pTelefono, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Empleado nuevoEmpleado = new Empleado();

                nuevoEmpleado.dni = pDni;
                nuevoEmpleado.apellido = pApellido;
                nuevoEmpleado.nombre = pNombre;
                nuevoEmpleado.email = pEmail;
                nuevoEmpleado.direccion = pDireccion;
                nuevoEmpleado.telefono = pTelefono;
                nuevoEmpleado.estado = pEstado;
                nuevoEmpleado.fechaAlta = DateTime.Now;

                db.Empleado.Add(nuevoEmpleado);
                db.SaveChanges();
            }
        }

        public void editarEmpleado(Int64 pDni, string pApellido, string pNombre, string pEmail, string pDireccion, long pTelefono, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                //Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).First();
                if (pEstado == 0)
                {
                    CD_Usuario usuario = new CD_Usuario();
                    Usuario usuarioSelect = usuario.UnUsuario(pDni);
                    Rol rolSelec = db.Rol.Where(s => s.idRol == usuarioSelect.idRol).FirstOrDefault();
                    if (usuario != null)
                    {
                        usuario.editarUsuario(usuarioSelect.dni, usuarioSelect.usuario1, rolSelec.descripcion, usuarioSelect.contraseña, 0);
                        Empleado pEmpleado = new Empleado();

                        pEmpleado.dni = pDni;
                        pEmpleado.apellido = pApellido;
                        pEmpleado.nombre = pNombre;
                        pEmpleado.email = pEmail;
                        pEmpleado.direccion = pDireccion;
                        pEmpleado.telefono = pTelefono;
                        pEmpleado.estado = pEstado;
                        pEmpleado.fechaAlta = DateTime.Now;

                        db.Entry(pEmpleado).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        Empleado pEmpleado = new Empleado();

                        pEmpleado.dni = pDni;
                        pEmpleado.apellido = pApellido;
                        pEmpleado.nombre = pNombre;
                        pEmpleado.email = pEmail;
                        pEmpleado.direccion = pDireccion;
                        pEmpleado.telefono = pTelefono;
                        pEmpleado.estado = pEstado;
                        pEmpleado.fechaAlta = DateTime.Now;

                        db.Entry(pEmpleado).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                
            }
        }

        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oEmpleado = from Empleado in db.Empleado
                                               select new
                                               {
                                                   DNI = Empleado.dni,
                                                   APELLIDO = Empleado.apellido,
                                                   NOMBRE = Empleado.nombre,
                                                   EMAIL = Empleado.email,
                                                   DIRECCION = Empleado.direccion,
                                                   TELEFONO = Empleado.telefono,
                                                   ESTADO = (Empleado.estado == 1 ? "Activo" : "Inactivo")

                                               };
                return oEmpleado.ToList();
            }


        }


        public List<Object> ListarConsulta()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oEmpleado = from Empleado in db.Empleado
                                               where Empleado.estado == 1
                                               select new
                                               {
                                                   DNI = Empleado.dni,
                                                   APELLIDO = Empleado.apellido,
                                                   NOMBRE = Empleado.nombre,
                                                   EMAIL = Empleado.email,
                                                   DIRECCION = Empleado.direccion,
                                                   TELEFONO = Empleado.telefono,
                                                   ESTADO = (Empleado.estado == 1 ? "Activo" : "Inactivo")

                                               };
                return oEmpleado.ToList();
            }


        }


        public List<Empleado> ListaEmpleado()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {


                List<Empleado> oEmpleado = db.Empleado.ToList();

                return oEmpleado;


            }

        }

        public List<Int64> ListaDNI()
        {

            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<long> listaDNI = from Empleado in db.Empleado
                                           select Empleado.dni;
                return listaDNI.ToList();

            }

        }


        public Empleado UnEmpleado(Int64 pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).First();
                    return empleadoSelect;
                }
                catch
                {
                    return null;
                }
            }
        }



        public Boolean DniExiste(Int64 pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean dniExiste = false;
                List<Empleado> listaEmpleado = ListaEmpleado();

                foreach (var unEmpleado in listaEmpleado)
                {
                    //Empleado empl = (Empleado)unEmpleado;
                    if (pDni == unEmpleado.dni)
                    {
                        dniExiste = true;
                    }
                }

                return dniExiste;
            }

        }

        public Boolean EmailExiste(string pEmail)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean emailExiste = false;
                List<Empleado> listaEmpleado = ListaEmpleado();

                foreach (var unEmpleado in listaEmpleado)
                {
                    //Empleado empl = (Empleado)unEmpleado;
                    if (pEmail == unEmpleado.email)
                    {
                        emailExiste = true;
                    }
                }

                return emailExiste;
            }

        }
    }

}
