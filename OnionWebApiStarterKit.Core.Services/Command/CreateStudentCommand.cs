﻿using MediatR;
using OnionWebApiStarterKit.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionWebApiStarterKit.Core.Services.Command
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}