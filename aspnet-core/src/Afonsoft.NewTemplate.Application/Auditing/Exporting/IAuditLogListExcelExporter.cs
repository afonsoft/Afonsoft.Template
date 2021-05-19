using System.Collections.Generic;
using Afonsoft.NewTemplate.Auditing.Dto;
using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
