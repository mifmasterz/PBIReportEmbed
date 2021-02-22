using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simada.Dashboard.Data
{
    public class AppConstants
    {
        public static List<Report> Reports = new List<Report> { 
        new Report (){ No=1, Title= "Apotek",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiNWZkNTJiYjgtNjBhYi00YWQ5LWJmNWEtOWY5MDgwNDdiZDM4IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=2, Title= "IKOT",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiODYwY2U3ZGItNDY4OS00YzFhLTllMzUtOWVjMTgzNWY0NzlmIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=3, Title= "Industri Farmasi",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiZWQ2ZWMwOWQtOGFmOC00YjczLWE3ZWItZjk5NTdhMjhlOWUzIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=4, Title= "IOT",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiZTM3NjE3YWItZjhkZS00MmY5LWFlOTYtYzIxNDQxOGU0YjhiIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=5, Title= "Industri Kosmetik",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiODAyMGFhMDItODIyOS00NWM1LTgzZGEtYWVhMGMyNWFhZTFkIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=6, Title= "Instalasi Farmasi",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiZjA5YTc0NTEtYzRmZi00MjJiLWJiZjQtYzRjMWE1MmYxMjk1IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=7, Title= "IRTP",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiYTkyNjAzNzQtZTg1Zi00NjAzLWFhMWEtZjg4Nzg3YzdiNDI2IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D&pageName=ReportSection",Parameters=new string[]{ }  },
        new Report (){ No=8, Title= "PAK",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiN2U0MDEzZGUtYTNhMC00NjU1LWIwODQtMTk1NDZkMjVhYmM1IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=9, Title= "PBF",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiOTZhYzRkYjEtMWUzMi00N2NkLWE5ZTUtZDdiMTNlNTk3ODIzIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=10, Title= "Produksi Alkes",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiNjFiZWExMDYtZDA4Ni00MDQ5LTk5MTQtYWZlMjY1MTZlZDUwIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=11, Title= "Produksi PKRT",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiM2RlYjczOTUtMDBmNS00OTc2LThkNWUtNzg3ZjJjODU1YzVkIiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=12, Title= "Produsen RTASLKESPKRT",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiZGEzYjNiZTgtODcyZS00MmU2LWJhYWYtMzkxZTYxNDAwMzE1IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
     
        new Report (){ No=13, Title= "Toko Alkes",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiZDAzZjU0YjYtZjZlMC00MGZkLWEyNjEtZGFmYzllM2RhYTk3IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },
        new Report (){ No=14, Title= "Toko Obat",  ReportUrl="https://app.powerbi.com/view?r=eyJrIjoiOWI3ZGNkNDMtNTYwYS00MWQ1LWJjYmQtY2Q2YmZjZWY1NTE2IiwidCI6IjViMWZiNWUxLTU4ODEtNGQwNC1iMmIwLWQ4ZDk4YWNmNGZkMiIsImMiOjEwfQ%3D%3D",Parameters=new string[]{ }  },

        };
    }
}
