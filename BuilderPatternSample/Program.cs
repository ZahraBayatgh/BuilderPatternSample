using BuilderPatternSample;

Employee employee = new EmployeeBuilder()
   // .WithName("John Doe")
    .WithAge(30)
    .WithAddress("123 Main St")
    .WithJobTitle("Software Engineer")
  //  .WithSalary(80000.0)
    .Build();

