using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Dtos
{
    public abstract class BasePaginationParameters
    {
        internal virtual int PageSize { get; set; } = 10;

        public virtual int PageNumber { get; set; } = 1;

    }
}
