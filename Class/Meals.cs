using System.Collections.Generic;

namespace Exam_R
{
    public class ResponseObject
    {
        public List<Meal> Meals { get; set; }
        public Meal this[int index]
        {
            get
            {
                if (index >= 0 && index < Meals.Count)
                {
                    return Meals[index];
                }
                return null;
            }
        }
    }
}
