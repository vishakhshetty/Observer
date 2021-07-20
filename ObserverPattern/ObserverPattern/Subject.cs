﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface Subject 
    {
        int GetState { get; set; }
        public void attach(Observer o);
        public void detach(Observer o);
        //public void notifyUpdate(Message m);
        void ChangeState(int val);
    }
}
