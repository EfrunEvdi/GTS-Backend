﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskRelation
{
    public class CreateTaskRelationDto
    {
        public int TaskId1 { get; set; }
        public int UserId { get; set; }
        public int RelationTypeId { get; set; }
        public int TaskId2 { get; set; }
    }
}
