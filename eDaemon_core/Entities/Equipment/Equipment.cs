using System;
using System.Collections.Generic;
using System.Text;

namespace eDaemon_core.Entities.Equipment
{
    abstract class Equipment
    {
        private int _id;
        private bool _masterwork = false;
        private bool _magical = false;

        public string Name { get; set; }

        public Equipment()
        {

        }
        public Equipment(int id, bool masterwork, bool magical, string name)
        {
            _id = id;
            _masterwork = masterwork;
            _magical = magical;
            Name = name;
        }
    }
}
