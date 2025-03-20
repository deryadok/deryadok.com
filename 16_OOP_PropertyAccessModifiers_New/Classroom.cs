namespace _16_OOP_PropertyAccessModifiers_New
{
    class Classroom
    {
        private List<Student> _students;

        public string LabName { get; set; }
        public int Capacity { get; set; }

        public Classroom(string lab, int capacity)
        {
            LabName = lab;
            Capacity = capacity;
            _students = new List<Student>(capacity);
        }

        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public Student this[int index]
        {
            get
            {
                if (index < 0 || index > Capacity - 1)
                {
                    return null;
                }

                return _students[index];
            }
            set
            {
                _students[index] = value;
            }
        }

        public List<Student> this[char gender]
        {
            get
            {
                List<Student> list = new List<Student>();
                foreach (Student item in this.Students)
                {
                    if (item.Gender == gender)
                    {
                        list.Add(item);
                    }
                }

                return list;
            }
        }
    }
}
