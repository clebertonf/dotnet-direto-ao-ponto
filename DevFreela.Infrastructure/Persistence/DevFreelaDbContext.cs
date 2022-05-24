using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Projeto leilões", "Um projeto de leiloes diversos", 1,1, 5000),
                new Project("Projeto loja de carros", "Um projeto de loja de carros", 1,1, 10000),
                new Project("Projeto sistema de agendamento", "Um projeto de um sistema de agendamentos", 1,1, 15000),

            };
            Users = new List<User>
            {
                new User("Cleberton", "cleberton@gmail.com", new DateTime(1993, 09, 21)),
                new User("João", "joao@gmail.com", new DateTime(1995, 10, 25)),
                new User("Carlos", "carlosn@gmail.com", new DateTime(2000, 02, 18)),
            };
            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; private set; }
        public List<User> Users { get; private set; }
        public List<Skill> Skills { get; private set; }

    }
}
