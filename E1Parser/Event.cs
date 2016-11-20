﻿using System;

namespace E1Parser {
    sealed class Event {
        private string name;
        private DateTime date;
        private string place;
        private string address;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public DateTime Date {
            get {
                return date;
            }
            set {
                date = value;
            }
        }

        public string Place {
            get {
                return place;
            }
            set {
                place = value;
            }
        }

        public string Address {
            get {
                return address;
            }
            set {
                address = value;
            }
        }
    }
}