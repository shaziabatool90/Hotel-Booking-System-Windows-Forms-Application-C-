using System;
using DP_Project.Properties;
namespace DP_Project
{
    public abstract class RoomDecorator : IRoom
    {
        protected IRoom _decoratedRoom;

        public abstract string Description { get; }

        protected RoomDecorator(IRoom room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("room");
            }
            _decoratedRoom = room;
        }

        public abstract decimal GetCost();
        public abstract string GetDescription();
    }
    public class WiFiDecorator : RoomDecorator
    {
        public override string Description
        {
            get { return _decoratedRoom.Description; }
        }

        public WiFiDecorator(IRoom room) : base(room) { }

        public override decimal GetCost()
        {
            return _decoratedRoom.GetCost() + 500;
        }

        public override string GetDescription()
        {
            return _decoratedRoom.GetDescription() + ", with WiFi";
        }
    }
    public class MinibarDecorator : RoomDecorator
    {
        public override string Description
        {
            get { return _decoratedRoom.Description; }
        }

        public MinibarDecorator(IRoom room) : base(room) { }

        public override decimal GetCost()
        {
            return _decoratedRoom.GetCost() + 1000;
        }

        public override string GetDescription()
        {
            return _decoratedRoom.GetDescription() + ", with Minibar";
        }
    }
    public class RoomServiceDecorator : RoomDecorator
    {
        public override string Description
        {
            get { return _decoratedRoom.Description; }
        }

        public RoomServiceDecorator(IRoom room) : base(room) { }

        public override decimal GetCost()
        {
            return _decoratedRoom.GetCost() + 1500;
        }

        public override string GetDescription()
        {
            return _decoratedRoom.GetDescription() + ", with Room Service";
        }
    }
}