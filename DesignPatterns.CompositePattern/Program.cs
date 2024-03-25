

using DesignPatterns.CompositePattern;

Employee employee = new Employee { Name = "ufuk" };
Employee employee2 = new Employee { Name = "mehmet" };
Employee employee3 = new Employee { Name = "ahmet" };
Employee employee4 = new Employee { Name = "zeynep" };
Employee employee5 = new Employee { Name = "ali" };


employee.AddSubordinate(employee2);
employee.AddSubordinate(employee3);
employee2.AddSubordinate(employee5);



// içiçe nesne kullanımını pattern nidir . 


/* 
    ufuk
        {   
            mehmet
                  {
                    ali
                  }
            ahmet
        }
    zeynep

 */