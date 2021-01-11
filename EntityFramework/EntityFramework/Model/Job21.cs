using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Model
{
  
    public class Job21
    {
       
        public int id { get; set; }
        public string Role { get; set; }


        public int Pid { get; set; }
        [ForeignKey("Pid")]
        public Person21 person { get; set; }
    }
}




//----------------------------------------------------------------------------------


//    USE[sprathipati]
//GO

///****** Object:  Table [dbo].[jobs]    Script Date: 09-01-2021 22:37:59 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//CREATE TABLE [dbo].[jobs](

//[Id][int] IDENTITY(1, 1) NOT NULL,

//[Role] [nvarchar](max)NULL,
//	[PersonId] [int] NOT NULL,
// CONSTRAINT[PK_jobs] PRIMARY KEY CLUSTERED 
//(

//    [Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO

//ALTER TABLE [dbo].[jobs]  WITH CHECK ADD  CONSTRAINT [FK_jobs_persons_PersonId] FOREIGN KEY([PersonId])
//REFERENCES[dbo].[persons]([PersonId])
//ON DELETE CASCADE
//GO

//ALTER TABLE [dbo].[jobs] CHECK CONSTRAINT[FK_jobs_persons_PersonId]
//GO



