using NUnit.Framework;

namespace UserPosts.Services.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        UserService sut;

        [SetUp]
        public void Setup()
        {
            IUserRepository userRepository = new UserDummyRepo();
            IPostRepository postRepository = new PostDummyRepo();

            sut = new UserService(userRepository, postRepository);
        }

        [Test]
        public void Test()
        {
            var expected = new UserActiveRespose()
            {
                Email = "andrei@wtf.com",
                Status = UserPostsStatus.Inactive
            };

            var actual = sut.GetUserActiveRespose(1);

            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Status, actual.Status);
        }
    }
}
