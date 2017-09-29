﻿//****************************************************************************
// Description:
// Author: hiramtan@qq.com
//***************************************************************************
using System;

namespace HiSocket.Msg
{
    public interface IMsgRegister
    {
        void Regist(int id, Action<IByteArray> action);

        void Unregist(int id);

        void Dispatch(int id, IByteArray iByteArray);
    }
}