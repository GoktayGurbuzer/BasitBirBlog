namespace basic.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository(){
            _courses = new List<Course>(){
                new Course() {
                    Id = 1, 
                    Title = "ASP.NET Core", 
                    Description = "Net Core Kursu", 
                    Image="1.jpg", 
                    Tags = new string[]{"aspnet","web","masaüstü","kodlama"},
                    isActive = true,
                    isHome = true 
                    },
                new Course() {
                    Id = 2, 
                    Title = "PHP", 
                    Description = "PHP Kursu", 
                    Image="2.jpg",
                    Tags = new string[]{"php","web","kodlama"},
                    isActive = true,
                    isHome = true 
                    },
                new Course() {
                    Id = 3, 
                    Title = "Ptyhon", 
                    Description = "Django Kursu", 
                    Image="3.jpg",
                    isActive = true,
                    isHome = true 
                    },
                new Course() {
                    Id = 4, 
                    Title = "Javascript", 
                    Description = "Javascript Kursu", 
                    Image="1.jpg",
                    Tags = new string[]{"js","web","kodlama"},
                    isActive = false,
                    isHome = true 
                    },
            };
        }

        public static List<Course> Courses{
            get{
                return _courses;
            }
        }

        public static Course? GetById(int id){
            return _courses.FirstOrDefault(x => x.Id == id);
        }
    }
}