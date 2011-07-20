﻿using System.Text;
using Paramore.Services.CommandHandlers;

namespace Paramore.Services.CommandProcessor
{
    public class ChainPathExplorer
    {
        private readonly StringBuilder _buffer = new StringBuilder();

        public void AddToPath(HandlerName handlerName)
        {
            _buffer.AppendFormat("{0}|", handlerName);
        }

        public override string ToString()
        {
            return _buffer.ToString();
        }
    }
}