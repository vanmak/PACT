﻿using System;
using System.Collections.Generic;

namespace PactNet.Library
{
    public class UserService
    {
        public User Get(int id) {
            return new User {
                Id = id,
                Name = "Tony Stark",
                Occupation = "Iron Man",
                Roles = new List<Role>{
                    new Role {
                        Name = "Genius",
                        Description = "Building Jarvis, aka Vision, aka AI"
                    },
                    new Role {
                        Name = "CEO",
                        Description = "Lying to the board"
                    },
                    new Role {
                        Name = "Fighter",
                        Description = "Made Thanos bleed"
                    }
                }
            };
        }
        public User Post(int id)
        {
            return new User
            {
                Id = id,
                Name = "Ivan Makogon",
                Occupation = "Automation QA engineer",
                Roles = new List<Role>{
                    new Role {
                        Name = "Test APi",
                        Description = "Automation Test API test"
                    },
                    new Role {
                        Name = "Test UI",
                        Description = "Automation UI test"
                    },
                    new Role {
                        Name = "Test Manual",
                        Description = "Exploratory testing"
                    }
                }
            };
        }
    }
}
