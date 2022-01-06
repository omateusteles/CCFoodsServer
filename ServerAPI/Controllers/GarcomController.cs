﻿using System.Collections.Generic;
using ServerAPI.Models;
using ServerAPI.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace ServerAPI.Controllers
{
    [ApiController]
    public class GarcomController : ControllerBase
    {
        private readonly CCFoodsContext _context;
        private readonly GarcomDAL garcomDAL;
        
        public GarcomController(CCFoodsContext context)
        {
            _context = context;
            garcomDAL = new GarcomDAL(context);
        }

        //	GET:	api/Garcom
        [Route("garcons/todos")]
        public IEnumerable<Garcom> Get()
        {
            return garcomDAL.GetAll();
        }

        [Route("garcom/insert")]
        public void PostInsertGarcom(Garcom garcom)
        {
            garcom.OperacaoSincronismo = Models.Enums.OperacaoSincronismo.Sincronizado;
            garcomDAL.Insert(garcom);
        }
    }
}