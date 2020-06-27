/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.Rooms;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class RoomRepository : IRoomRepository
   {
        private readonly ICSVStream<Room> _stream = new CSVStream<Room>("../../Resources/Data/rooms.csv", new RoomCSVConverter(","));
        private readonly iSequencer<long> _sequencer = new LongSequencer();

        private String _path = "../../Resources/Data/rooms.csv";
        private static RoomRepository instance;

        public static RoomRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomRepository();
                }
                return instance;
            }
        }


        private RoomRepository()
        {
        }

        public RoomRepository(string path, CSVStream<Room> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<Room> rooms)
        {
            return rooms.Count() == 0 ? 0 : rooms.Max(ro => ro.Id);
        }

        public Room GetRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Room Save(Room obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Room Edit(Room obj)
        {
            var rooms = _stream.ReadAll().ToList();
            rooms[rooms.FindIndex(ro => ro.Id == obj.Id)] = obj;
            _stream.SaveAll(rooms);
            return obj;
        }

        public bool Delete(Room obj)
        {
            var rooms = _stream.ReadAll().ToList();
            var roomToRemove = rooms.SingleOrDefault(ro => ro.Id == obj.Id);
            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
                _stream.SaveAll(rooms);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Room> GetAll()
        {
            var rooms = (List<Room>)_stream.ReadAll();
            return rooms;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

       
   
   }
}