///<summary>
///观察者接口
///<summary>
namespace XFramework.Event
{
    public interface IObserver
    {
        void OnDataChange(EventData eventData, int type, object obj);
    }
}