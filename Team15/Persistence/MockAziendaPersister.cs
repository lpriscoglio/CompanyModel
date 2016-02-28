using System;
using System.Collections.Generic;
using System.Text;
using Team15.Model;

namespace Team15.Persistence
{
    public class MockAziendaPersister : IAziendaPersister
    {
        private MockAziendaLoader _loader;

        public MockAziendaPersister()
        {
            _loader  = new MockAziendaLoader();
        }

        public IAziendaLoader GetLoader()
        {
            return _loader;
        }

        public void Save(Azienda azienda)
        {
            //non implementato
            return;
        }
    }
}
