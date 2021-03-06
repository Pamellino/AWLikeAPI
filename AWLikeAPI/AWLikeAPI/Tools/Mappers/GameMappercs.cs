﻿using AWLikeAPI.Models;
using AWLikeAPI.Models.Game;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AWLikeAPI.Tools.Mappers
{
    public static class GameMappercs
    {
        public static GameInfo ToGameInfo(this GamePOCO g)
        {
            return new GameInfo
            {
                Id = g.Id,
                MapID = g.MapID,
                Name = g.Name,
                UserTurnNumb = g.UserTurnNumb,
                Ref_UserList = g.UserList.Select(x => x.ToGameUser()).ToList(),
                NumberOfPlayers = g.NumberOfPlayers
                
            };
        }
    }
}