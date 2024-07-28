﻿using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using XAct;
using XAct.Library.Settings;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiNet8.Services
{
    public class UsuarioEstadoServices : IUsuarioEstadoServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        public UsuarioEstadoServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
        }

        public UsuarioEstado ActualizarUsuarioEstado(UsuarioEstadoDTO usEst, JwtToken currentUserJwt)
        {
            try
            {
                //UsuarioEstado usuarioEstado;
                //using (var transaction = _db.Database.BeginTransaction())
                //{
                //    usuarioEstado = ((IUsuarioEstadoServices)this).GetUsuarioEstadoById(usEst.Id);
                //    usuarioEstado.NombreEstado = usEst.NombreEstado;
                //    usuarioEstado.DescripcionEstado = usEst.DescripcionEstado;
                //    usuarioEstado.FechaModificacion = DateTime.Now;
                //    usuarioEstado.UsuarioEditor = usEst.UsuarioEditor;//Implementar CurrentUser
                //    _db.Update(usuarioEstado);
                //    _db.SaveChanges();
                //    transaction.Commit();
                //}
                //return usuarioEstado;

                //mapper de usuariodto a usuario
                UsuarioEstado estUs = _mapper.Map<UsuarioEstado>(usEst);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    estUs.FechaModificacion = DateTime.Now;
                    estUs.UsuarioEditor = currentUserJwt.Id;
                    _db.Update(estUs);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return estUs;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }

        public UsuarioEstado CrearUsuarioEstado(UsuarioEstadoDTO usuarioEstado, JwtToken currentUserJwt)
        {
            try
            {
                //mapper de usuariodto a usuario
                UsuarioEstado estUs = _mapper.Map<UsuarioEstado>(usuarioEstado);

                estUs.FechaCreacion = DateTime.Now;
                estUs.UsuarioEditor = currentUserJwt.Id;
                _db.Add(estUs);
                _db.SaveChanges();
                return estUs;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public UsuarioEstado EliminarUsuarioEstado(int id, JwtToken currentUserJwt)
        {
            try
            {
                UsuarioEstado usuarioEstado = this.GetUsuarioEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    usuarioEstado.FechaBaja = DateTime.Now;
                    usuarioEstado.UsuarioEditor = currentUserJwt.Id;
                    _db.Update(usuarioEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return usuarioEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public bool ExisteUsuarioEstado(string nombre)
        {
            var usuarioEst = _db.UsuarioEstado.FirstOrDefault(ue => ue.NombreEstado == nombre);
            if (usuarioEst == null)
            {
                return false;
            }
            return true;
        }

        public UsuarioEstado GetUsuarioEstadoById(int Id)
        {
            try
            {
                UsuarioEstado usuarioEstado = _db.UsuarioEstado.Find(Id);

                return usuarioEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }


        public List<UsuarioEstado> GetUsuarioEstados()
        {
            try
            {
                return _db.UsuarioEstado.ToList();// podriamos devolverlos ordenados por id
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

    }
}
