using Xunit;
using System.Threading.Tasks;
using openrmf_save_api.Data;
using openrmf_save_api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;

/*
 *  Do note:
 *  These tests will fail without a proper
 *  MongoDB setup locally. Refer to the README
 *  in this repo or https://github.com/Cingulara/openrmf-docs/blob/master/create-users-by-hand.md
 */

namespace tests.Data
{
    public class SystemGroupRepositoryTests
    {
        private readonly SystemGroupRepository _systemGroupRepository;

        public SystemGroupRepositoryTests()
        {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _systemGroupRepository = new SystemGroupRepository(Options.Create<Settings>(settings)); 
        }

        [Fact]
        public async Task Test_SystemGroupRepositoryIsValid()
        {
            SystemGroup sysGroup = new SystemGroup();
            ObjectId objId = ObjectId.GenerateNewId();
            
            sysGroup.InternalId = objId;

            // Testing
            Assert.False(_systemGroupRepository == null);

            /*
            await _systemGroupRepository.GetAllSystemGroups();
            await _systemGroupRepository.AddSystemGroup(sysGroup);
            await _systemGroupRepository.GetSystemGroup(objId.ToString());
            await _systemGroupRepository.UpdateSystemGroup(objId.ToString(), sysGroup);
            await _systemGroupRepository.DeleteSystemGroup(objId.ToString());
            */

        }
    }
}
