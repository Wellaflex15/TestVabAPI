using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiToJson.Models
{
    public class QVab
    {
        public int QvabNumber { get; set; }
        // public string QvabName { get; set; }

        public QVab() { }
        public QVab(int qvabNumber)
        {
            QvabNumber = qvabNumber;
            // QvabName = qvabName;
        }
    }
}
