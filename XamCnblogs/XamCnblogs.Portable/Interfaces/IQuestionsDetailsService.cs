﻿using XamCnblogs.Portable.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCnblogs.Portable.Interfaces
{
    public interface IQuestionsDetailsService
    {
        Task<ResponseMessage> GetQuestionsAsync(int id);
    }
}