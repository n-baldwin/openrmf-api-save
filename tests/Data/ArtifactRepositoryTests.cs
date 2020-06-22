using Xunit;
using System;
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
    public class ArtifactRepositoryTests
    {
        private readonly IOptions<Settings> _optSettings;
        private readonly ArtifactRepository _artifactRepository;

        public ArtifactRepositoryTests()
        {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _optSettings = Options.Create<Settings>(settings);
            _artifactRepository = new ArtifactRepository(_optSettings); 
        }

        [Fact]
        public async Task Test_ArtifactRepositoryIsValid()
        {
            Artifact artifact = new Artifact();
            ObjectId objId = ObjectId.GenerateNewId();

            artifact.InternalId = objId;

            // Testing
            Assert.False(_artifactRepository == null);

            /*
            await _artifactRepository.GetAllArtifacts();
            await _artifactRepository.GetArtifact(objId.ToString());
            await _artifactRepository.GetArtifact("body", DateTime.Now, 256);
            await _artifactRepository.GetArtifactBySystem("systemid", objId.ToString());
            await _artifactRepository.GetSystemArtifacts("systemid");
            await _artifactRepository.AddArtifact(artifact);
            await _artifactRepository.UpdateArtifact(objId.ToString(), artifact);
            await _artifactRepository.DeleteArtifact(objId.ToString());
            */
        }
    }
}
