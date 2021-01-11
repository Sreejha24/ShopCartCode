using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Model
{
   
    public class Person21
    {
       
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Personid { get; set; }
        public ICollection<Job21> job { get; set; }
    }
}


//---------------------------------------------------------------------------


//    USE[sprathipati]
//GO

///****** Object:  Table [dbo].[persons]    Script Date: 09-01-2021 22:39:28 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//CREATE TABLE [dbo].[persons](

//[PersonId][int] IDENTITY(1, 1) NOT NULL,

//[FirstName] [nvarchar](max)NULL,
//	[LastName] [nvarchar](max)NULL,
//	[Age] [int] NOT NULL,

//    [Gender] [nvarchar](max)NULL,
//	[Mobile] [bigint] NOT NULL,
// CONSTRAINT[PK_persons] PRIMARY KEY CLUSTERED 
//(

//    [PersonId] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO



