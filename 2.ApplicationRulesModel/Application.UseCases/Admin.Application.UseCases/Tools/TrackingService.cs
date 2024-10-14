using Admin.Application.DTOs.Common;

using System.Text.Json;

namespace Admin.Application.UseCases.Tools
{
    public static class TrackingService
    {
        public static string ProcessTrackingEvents(string trackingData)
        {
            List<TrackingEventDTO> trackingEvents = new List<TrackingEventDTO>();

            if (!string.IsNullOrEmpty(trackingData))
            {
                try
                {
                    var newTrackingEvent = JsonSerializer.Deserialize<TrackingEventDTO>(trackingData);
                    if (newTrackingEvent != null)
                    {
                        trackingEvents.Add(newTrackingEvent);
                    }
                }
                catch (JsonException ex)
                {
                    return "";
                }
            }

            return JsonSerializer.Serialize(trackingEvents);
        }

        public static string AddTrackingEvents(string trackingData, string mewTraking)
        {
            List<TrackingEventDTO> trackingEventDTOs = new List<TrackingEventDTO>();

            if (!string.IsNullOrEmpty(trackingData))
            {
                try
                {
                    trackingEventDTOs = JsonSerializer.Deserialize<List<TrackingEventDTO>>(trackingData) ?? new List<TrackingEventDTO>();
                }
                catch (JsonException ex)
                {
                }
            }

            if (!string.IsNullOrEmpty(mewTraking))
            {
                try
                {
                    var newTrackingEvent = JsonSerializer.Deserialize<TrackingEventDTO>(mewTraking);
                    if (newTrackingEvent != null)
                    {
                        trackingEventDTOs.Add(newTrackingEvent);
                    }
                }
                catch (JsonException ex)
                {
                }
            }
            return JsonSerializer.Serialize(trackingEventDTOs);
        }
    }
}