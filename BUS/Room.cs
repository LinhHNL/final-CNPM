﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class Room
    {
        public List<Dictionary<string, string>> gettingRoom()
        {
            DAO.Room Room = new DAO.Room();
            return Room.getAllRoom();
        }
    }
}
