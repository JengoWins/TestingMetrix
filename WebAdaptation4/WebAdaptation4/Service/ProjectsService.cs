using WebAdaptation4.DBase;
using WebAdaptation4.Model;

namespace WebAdaptation4.Service
{

    public interface IProject
    {
        List<MisterOne> JobProjects();
    }

    public class ProjectsService : IProject
    {
        List<MisterOne> values = new List<MisterOne>();
        private readonly ApplicationContext _context;
        public List<MisterOne> JobProjects()
        {
            MisterOne one = new MisterOne()
            {
                id = 1,
                Summary = "Nulls"
            };
            values.Add(one);    
            return values;
        }
    }
}
