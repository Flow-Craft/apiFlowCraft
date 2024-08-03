﻿using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using AutoMapper;

namespace ApiNet8.Services
{
    public class EventoEstadoService : IEventoEstadoService
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;

        public EventoEstadoService(ApplicationDbContext db, IConfiguration configuration, IMapper mapper)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
        }
        public EstadoEvento ActualizarEventoEstado(EstadoEventoDTO eventoEstadoDTO, JwtToken currentUserJwt)
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
                EstadoEvento estEvent = _mapper.Map<EstadoEvento>(eventoEstadoDTO);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    estEvent.FechaModificacion = DateTime.Now;
                    estEvent.UsuarioEditor = currentUserJwt.Id;
                    _db.Update(estEvent);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return estEvent;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }

        public EstadoEvento CrearEventoEstado(EstadoEventoDTO eventoEstadoDTO, JwtToken currentUserJwt)
        {
            try
            {
                //mapper de usuariodto a usuario
                EstadoEvento estEvent = _mapper.Map<EstadoEvento>(eventoEstadoDTO);

                estEvent.FechaCreacion = DateTime.Now;
                estEvent.UsuarioEditor = currentUserJwt.Id;
                _db.Add(estEvent);
                _db.SaveChanges();
                return estEvent;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public EstadoEvento EliminarEventoEstado(int id, JwtToken currentUserJwt)
        {
            try
            {
                EstadoEvento eventoEstado = this.GetEventoEstadoById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    eventoEstado.FechaBaja = DateTime.Now;
                    eventoEstado.UsuarioEditor = currentUserJwt.Id;
                    _db.Update(eventoEstado);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return eventoEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteEventoEstado(string nombre)
        {
            var eventEst = _db.EstadoEvento.FirstOrDefault(ee => ee.NombreEstado == nombre);
            if (eventEst == null)
            {
                return false;
            }
            return true;
        }

        public EstadoEvento GetEventoEstadoById(int Id)
        {
            try
            {
                EstadoEvento eventEstado = _db.EstadoEvento.Find(Id);

                return eventEstado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<EstadoEvento> GetEventoEstados()
        {
            try
            {
                return _db.EstadoEvento.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}