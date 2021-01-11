using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework
{
    public class Employees
    {

        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public long Mobile { get; set; }
    }
}


//---------------------------------------------------------------------

//    USE[sprathipati]
//GO

///****** Object:  Table [dbo].[Employees]    Script Date: 09-01-2021 22:41:13 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//CREATE TABLE [dbo].[Employees](

//[EmployeeID][int] IDENTITY(1, 1) NOT NULL,

//[FirstName] [varchar](255) NOT NULL,

//[LastName] [varchar](255) NULL,
//	[Email] [varchar](200) NULL,
//	[City] [varchar](255) NULL,
//	[Mobile] [bigint] NULL,
//PRIMARY KEY CLUSTERED 
//(

//    [EmployeeID] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY]
//GO



