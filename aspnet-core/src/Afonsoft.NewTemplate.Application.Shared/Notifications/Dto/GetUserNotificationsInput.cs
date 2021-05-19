using System;
using Abp.Notifications;
using Afonsoft.NewTemplate.Dto;

namespace Afonsoft.NewTemplate.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}