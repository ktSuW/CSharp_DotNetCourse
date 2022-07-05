# .NET core package course

---

<details>
  <summary> Week - 1 Introduction </summary>

## Section 1

- **C# .net :** is a programming language which is used to write coding part for the application development
- **ASP.net core :** Active Server Page -- web technology or server side technology design the websites or webpages
  - Client server architecture
- **Basic UI Technologies :** HTML + CSS + JavaScript + JQuery + Bootstrap
- **SQL server :** Relational database management system
  - Storage area
- **Asp.net core MVC :** Model View Controller architecture design pattern
  - Model (database layer)
  - View (Presentation layer)
  - Controller (Server)
  - Split the code - Single Responsibility
- **Asp.net core Web API :** is a framework for building RESTful application.
- **Ado.net :** Active X data object
  - Native driver software communicates frontend (asp.net) and backend

## Section - 2

- What is .net?
  - **n**etwork **e**nabled **t**echnology - net
  - .net is a framework tool which supports around 60+ programming languages.
  - first version 2002
- What is .net framework?
  - .net framework is a collection of class libraries.
  - class libraries is a collection of predefined classes.
- .net core vs .net framework
  - After 2016, .net core was released and can be run on any OS.
  - Therefore .net core is platform independent
  - .net can be used to build different types of application
    - Standalone application (Desktop application)
      - console app
      - windows forms application (GUI) e.g. Notepad
      - windows presentation foundation (WPF)
      - windows services
    - **Distributed application or online application**
      - web applications
      - MVC applications
      - Web services
      - **web API**
      - business applications
      - network based app
      - gaming application
      - Window communication foundation (WCF)
- [Download Visual Studio](https://visualstudio.microsoft.com/downloads/)
- [Download SQL Server 2019](https://www.microsoft.com/en-au/sql-server/sql-server-downloads?SilentAuth=1&wa=wsignin1.0)
- [SSMS SQL Server - Download SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
  - After downloading, add server name. It could be localhost
  - Check for Azure Data Studio, in server name, add dot .

## Section - 3

- Code execution Process

  - source code -> langauge compiler -> After successful compilation, it will be converted into byte code -> OS
  - First compilation
    - Source code will be converted into MSIL code with the help of language compiler.
    - By the end of this first compilation, the code is still in english.
  - Second compilation
    - Just In Time compiler converts Microsoft Intermediate language (MSIL) or Common Intermediate langauge into native machine code with the help of CLR (common language runtime)

  <img src="img/compilation.jpg" width = 600>

## Section - 4

- .net components:
  - Base class libraries : write 
  - CLR - common language runtime : run 
- Base class libraries 
  - They are building blocks of .net 
  - They are similar to header files in C & C++
  - They are also called as namespaces 
  - BCL or Framework class library (FCL) : They are in two forms:
    - .exe - executable file that can be run directly. It has entry point , i.e., static void Main()
    - dll - dynamic link library - supportive file , no entry point 
      - This is for reusability 
- Common language runtime : without this, you cannot run the code. CLR provides a runtime environment to run the program. The sub-components are : 
  - CLS - common language specification : write in one programming language and execute in another programming langauge (e.g. C# -> )
  - CTS - common type system or datatype system 
    - Value type -- int a = 10; compile time -- stack
    - Reference type -- int b = a; runtime ---- heap
  - GC - garbage collector 
    - Provides automatic memory management , allocate and de-allocate memory
    - Can be divided into three generations:
      - generation 0 - newly created objects must be stored in gen 0 (Garbage collector rule). Idled objects are flushed out to the gen 1.
      - generation 1 - if there is no more space in the gen 0 and want to create new object, there is where collection means method comes in. 
      - generation 2
      - memory space are gen 0 < gen 2 < gen 3 . Therefore, gen 3 has largest memory
      - When all gens are full, automatically, memory will be expanded.
    - It also have Optimised engine. It performs a mechanism called collection means method to find out objects are useful or not. 
    - It divides objects into two categories :
      - Objects in use
      - Idled objects (Garbage) - should be destoryed. Automatic memory management 
      - Destructor 
    - <img src="img/gc_collector.jpg" width = 600>
      -
  - JIT - Just in time compiler 
    - Used to compile MSL code into native code 
- C# .net 
  - # sharp - musical note 
  - C# net = c++, VB6.0 + Java + additional features 
  - functional oriented 
  - object oriented 
  - Case sensitive 
## Section - 5

- Console app 

## Section - 6

## Section - 7

## Section - 8

  </details>

---

<details>
  <summary> Week - 2 </summary>
  ## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 3 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 4 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 5 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 6 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 7 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 8 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 9 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 10 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 11 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 12 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 13 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 14 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 15 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 16 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 17 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---

<details>
  <summary> Week - 18 </summary>

## Section - 1

## Section - 2

## Section - 3

## Section - 4

## Section - 5

## Section - 6

</details>

---
