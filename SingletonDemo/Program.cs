using SingletonDemo;


////with sealed
//Singleton employee = Singleton.GetInstance;
//employee.PrintDetails("Hello Employee");
//Singleton student = Singleton.GetInstance;
//student.PrintDetails("Hello student");




////without sealed
//SingletonWithoutSealed employee2 = SingletonWithoutSealed.GetInstance;
//employee2.PrintDetails("Hello Employee 2");
//SingletonWithoutSealed student2 = SingletonWithoutSealed.GetInstance;
//student2.PrintDetails("Hello student 2");
//SingletonWithoutSealed employee3 = SingletonWithoutSealed.GetInstance;
//employee3.PrintDetails("Hello Employee 3");
//Console.WriteLine("------------------------------------------------------------------------");
//SingletonWithoutSealed.DerivedClass derived = new SingletonWithoutSealed.DerivedClass();
//derived.PrintDetails("Hello from derived without sealed");




////with locks
//Parallel.Invoke(
//    () => PrintEmployeeDetails(),
//    () => PrintStudentDetails()
//    );
//static void PrintEmployeeDetails()
//{
//    SingletonWithLocks employee = SingletonWithLocks.GetInstance;
//    employee.PrintDetails("Hello Employee");
//}

//static void PrintStudentDetails()
//{
//    SingletonWithLocks student = SingletonWithLocks.GetInstance;
//    student.PrintDetails("Hello student");
//}



////eager loading
//Parallel.Invoke(
//    () => PrintEmployeeDetailsEager(),
//    () => PrintStudentDetailsEager()
//    );
//static void PrintEmployeeDetailsEager()
//{
//    SingletonEagerLoading employee = SingletonEagerLoading.GetInstance;
//    employee.PrintDetails("Hello Employee");
//}

//static void PrintStudentDetailsEager()
//{
//    SingletonEagerLoading student = SingletonEagerLoading.GetInstance;
//    student.PrintDetails("Hello student");
//}



////lazy initialization
//Parallel.Invoke(
//    () => PrintEmployeeDetailsLazy(),
//    () => PrintStudentDetailsLazy()
//    );
//static void PrintEmployeeDetailsLazy()
//{
//    SingletonLazyInitialization employee = SingletonLazyInitialization.GetInstance;
//    employee.PrintDetails("Hello Employee");
//}

//static void PrintStudentDetailsLazy()
//{
//    SingletonLazyInitialization student = SingletonLazyInitialization.GetInstance;
//    student.PrintDetails("Hello student");
//}



Console.ReadLine();

