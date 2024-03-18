using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.entity
{
    internal class TasksEntity
    {
        long _id;
        long _userid;
        string _nameT;
        string _status;
        DateTime _time_start;
        DateTime _time_stop;

        public TasksEntity(long id, long userid, string nameT, string st, DateTime timrstart, DateTime timrstop)
        {
            _id = id;
            _userid = userid;
            _nameT = nameT;
            _status = st;
            _time_start = timrstart;
            _time_stop = timrstop;
        }
        public long Id { get { return _id; } }
        public long Userid { get { return _userid; } }

        public string NameT { get { return _nameT; } }
        public string Status { get { return _status; } }
        public DateTime timestart { get { return _time_start; } set { _time_start = value; } }
        public DateTime timestop { get { return _time_stop; } set { _time_stop = value; } }
    }
}
