﻿using ControlApp.CCI.CCI_Message;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string json = "{\r\n  \"m_oDeviceInformationList\": [\r\n    {\r\n      \"Name\": \"Template HS200 Vial 9mm\",\r\n      \"ID\": 425,\r\n      \"StorageCapacity\": 19572,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 2,\r\n      \"Connection\": false,\r\n      \"Priority\": false,\r\n      \"Succession\": 0,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 0,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200_03028\",\r\n      \"ID\": 1332,\r\n      \"StorageCapacity\": 1634,\r\n      \"StorageUse\": 5,\r\n      \"Typ\": 2,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 2,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-25T11:36:29\",\r\n          \"Temp\": 18.8,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:36:29\",\r\n          \"Temp\": 20.1,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:36:29\",\r\n          \"Temp\": 20.0,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 2,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200-M-00002\",\r\n      \"ID\": 109,\r\n      \"StorageCapacity\": 19020,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 5,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2017-07-21T17:04:12\",\r\n          \"Temp\": -159.8,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2017-07-21T17:04:12\",\r\n          \"Temp\": -63.0,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2017-07-21T17:04:12\",\r\n          \"Temp\": -71.6,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200-L-00001\",\r\n      \"ID\": 134,\r\n      \"StorageCapacity\": 19116,\r\n      \"StorageUse\": 10,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 1,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-02-09T11:18:43\",\r\n          \"Temp\": -155.0,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-02-09T11:18:43\",\r\n          \"Temp\": -135.0,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-03-14T14:16:36\",\r\n          \"Temp\": -150.0,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 10\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_PT1\",\r\n      \"ID\": 169,\r\n      \"StorageCapacity\": 37420,\r\n      \"StorageUse\": 3,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 2,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-25T11:23:24\",\r\n          \"Temp\": -156.8,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:23:24\",\r\n          \"Temp\": -61.3,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:23:24\",\r\n          \"Temp\": -107.1,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_SN003\",\r\n      \"ID\": 237,\r\n      \"StorageCapacity\": 11396,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 2,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-25T11:37:55\",\r\n          \"Temp\": -172.5,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:37:55\",\r\n          \"Temp\": -120.3,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:37:55\",\r\n          \"Temp\": -129.9,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_SN004\",\r\n      \"ID\": 1413,\r\n      \"StorageCapacity\": 118875,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 4,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-16T14:43:08\",\r\n          \"Temp\": 850.0,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-16T14:43:08\",\r\n          \"Temp\": 20.7,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-16T14:43:08\",\r\n          \"Temp\": 21.1,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_REFERENZ\",\r\n      \"ID\": 1753,\r\n      \"StorageCapacity\": 41814,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 6,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 3\r\n    },\r\n    {\r\n      \"Name\": \"AWB-00001\",\r\n      \"ID\": 1667,\r\n      \"StorageCapacity\": 0,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 23,\r\n      \"Connection\": false,\r\n      \"Priority\": false,\r\n      \"Succession\": 0,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 0,\r\n      \"CachePendingCount\": 2\r\n    }\r\n  ],\r\n  \"m_MsgType\": 9,\r\n  \"m_MsgID\": 0,\r\n  \"Token\": {\r\n    \"TokenType\": 0\r\n  },\r\n  \"m_ErrorCode\": 0,\r\n  \"m_ErrorMessage\": \"\"\r\n}";
            string json2 = "{\r\n  \"m_oDeviceInformationList\": [\r\n    {\r\n      \"Name\": \"Template HS200 Vial 9mm\",\r\n      \"ID\": 425,\r\n      \"StorageCapacity\": 19572,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 2,\r\n      \"Connection\": false,\r\n      \"Priority\": false,\r\n      \"Succession\": 0,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 0,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200_03028\",\r\n      \"ID\": 1332,\r\n      \"StorageCapacity\": 1634,\r\n      \"StorageUse\": 5,\r\n      \"Typ\": 2,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 2,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-25T11:36:29\",\r\n          \"Temp\": 18.8,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:36:29\",\r\n          \"Temp\": 20.1,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:36:29\",\r\n          \"Temp\": 20.0,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 2,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200-M-00002\",\r\n      \"ID\": 109,\r\n      \"StorageCapacity\": 19020,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 5,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2017-07-21T17:04:12\",\r\n          \"Temp\": -159.8,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2017-07-21T17:04:12\",\r\n          \"Temp\": -63.0,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2017-07-21T17:04:12\",\r\n          \"Temp\": -71.6,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200-L-00001\",\r\n      \"ID\": 134,\r\n      \"StorageCapacity\": 19116,\r\n      \"StorageUse\": 10,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 1,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-02-09T11:18:43\",\r\n          \"Temp\": -155.0,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-02-09T11:18:43\",\r\n          \"Temp\": -135.0,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-03-14T14:16:36\",\r\n          \"Temp\": -150.0,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 10\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_PT1\",\r\n      \"ID\": 169,\r\n      \"StorageCapacity\": 37420,\r\n      \"StorageUse\": 3,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 2,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-25T11:23:24\",\r\n          \"Temp\": -156.8,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:23:24\",\r\n          \"Temp\": -61.3,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:23:24\",\r\n          \"Temp\": -107.1,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_SN003\",\r\n      \"ID\": 237,\r\n      \"StorageCapacity\": 11396,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 2,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-25T11:37:55\",\r\n          \"Temp\": -172.5,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:37:55\",\r\n          \"Temp\": -120.3,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-25T11:37:55\",\r\n          \"Temp\": -129.9,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_SN004\",\r\n      \"ID\": 1413,\r\n      \"StorageCapacity\": 118875,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 4,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"2018-01-16T14:43:08\",\r\n          \"Temp\": 850.0,\r\n          \"Sensor\": 1,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-16T14:43:08\",\r\n          \"Temp\": 20.7,\r\n          \"Sensor\": 2,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"2018-01-16T14:43:08\",\r\n          \"Temp\": 21.1,\r\n          \"Sensor\": 3,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 0\r\n    },\r\n    {\r\n      \"Name\": \"HS200M_REFERENZ\",\r\n      \"ID\": 1753,\r\n      \"StorageCapacity\": 41814,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 19,\r\n      \"Connection\": false,\r\n      \"Priority\": true,\r\n      \"Succession\": 6,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        },\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 1,\r\n      \"CachePendingCount\": 3\r\n    },\r\n    {\r\n      \"Name\": \"AWB-00001\",\r\n      \"ID\": 1667,\r\n      \"StorageCapacity\": 0,\r\n      \"StorageUse\": 0,\r\n      \"Typ\": 23,\r\n      \"Connection\": false,\r\n      \"Priority\": false,\r\n      \"Succession\": 0,\r\n      \"Temprature\": [\r\n        {\r\n          \"Time\": \"0001-01-01T00:00:00\",\r\n          \"Temp\": 0.0,\r\n          \"Sensor\": 0,\r\n          \"Status\": 0\r\n        }\r\n      ],\r\n      \"StorageMethod\": 0,\r\n      \"CachePendingCount\": 2\r\n    }\r\n  ],\r\n  \"m_MsgType\": 9,\r\n  \"m_MsgID\": 0,\r\n  \"m_ErrorCode\": 0,\r\n  \"m_ErrorMessage\": \"\"\r\n}";
            string json3 = "{\"m_oDeviceInformationList\":[{\"Name\":\"Template HS200 Vial 9mm\",\"ID\":425,\"StorageCapacity\":19572,\"StorageUse\":0,\"Typ\":2,\"Connection\":false,\"Priority\":false,\"Succession\":0,\"Temprature\":[{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0}],\"StorageMethod\":0,\"CachePendingCount\":0},{\"Name\":\"HS200_03028\",\"ID\":1332,\"StorageCapacity\":1634,\"StorageUse\":5,\"Typ\":2,\"Connection\":false,\"Priority\":true,\"Succession\":2,\"Temprature\":[{\"Time\":\"2018-01-25T11:36:29\",\"Temp\":18.8,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-25T11:36:29\",\"Temp\":20.1,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-25T11:36:29\",\"Temp\":20.0,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":2,\"CachePendingCount\":0},{\"Name\":\"HS200-M-00002\",\"ID\":109,\"StorageCapacity\":19020,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":5,\"Temprature\":[{\"Time\":\"2017-07-21T17:04:12\",\"Temp\":-159.8,\"Sensor\":1,\"Status\":0},{\"Time\":\"2017-07-21T17:04:12\",\"Temp\":-63.0,\"Sensor\":2,\"Status\":0},{\"Time\":\"2017-07-21T17:04:12\",\"Temp\":-71.6,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200-L-00001\",\"ID\":134,\"StorageCapacity\":19116,\"StorageUse\":10,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":1,\"Temprature\":[{\"Time\":\"2018-02-09T11:18:43\",\"Temp\":-155.0,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-02-09T11:18:43\",\"Temp\":-135.0,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-03-14T14:16:36\",\"Temp\":-150.0,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":10},{\"Name\":\"HS200M_PT1\",\"ID\":169,\"StorageCapacity\":37420,\"StorageUse\":3,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":2,\"Temprature\":[{\"Time\":\"2018-01-25T11:23:24\",\"Temp\":-156.8,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-25T11:23:24\",\"Temp\":-61.3,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-25T11:23:24\",\"Temp\":-107.1,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200M_SN003\",\"ID\":237,\"StorageCapacity\":11396,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":2,\"Temprature\":[{\"Time\":\"2018-01-25T11:37:55\",\"Temp\":-172.5,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-25T11:37:55\",\"Temp\":-120.3,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-25T11:37:55\",\"Temp\":-129.9,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200M_SN004\",\"ID\":1413,\"StorageCapacity\":118875,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":4,\"Temprature\":[{\"Time\":\"2018-01-16T14:43:08\",\"Temp\":850.0,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-16T14:43:08\",\"Temp\":20.7,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-16T14:43:08\",\"Temp\":21.1,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200M_REFERENZ\",\"ID\":1753,\"StorageCapacity\":41814,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":6,\"Temprature\":[{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":3},{\"Name\":\"AWB-00001\",\"ID\":1667,\"StorageCapacity\":0,\"StorageUse\":0,\"Typ\":23,\"Connection\":false,\"Priority\":false,\"Succession\":0,\"Temprature\":[{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0}],\"StorageMethod\":0,\"CachePendingCount\":2}],\"m_MsgType\":9,\"m_MsgID\":0,\"Token\":{\"TokenType\":0},\"m_ErrorCode\":0,\"m_ErrorMessage\":\"\"}";
            var o = JsonConvert.DeserializeObject<CCI_Message_DeviceInformation>(json3);
            */
            string json = "\"{\\\"m_oDeviceInformationList\\\":[{\\\"Name\\\":\\\"Template HS200 Vial 9mm\\\",\\\"ID\\\":425,\\\"StorageCapacity\\\":19572,\\\"StorageUse\\\":0,\\\"Typ\\\":2,\\\"Connection\\\":false,\\\"Priority\\\":false,\\\"Succession\\\":0,\\\"Temprature\\\":[{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0},{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0},{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0}],\\\"StorageMethod\\\":0,\\\"CachePendingCount\\\":0},{\\\"Name\\\":\\\"HS200_03028\\\",\\\"ID\\\":1332,\\\"StorageCapacity\\\":1634,\\\"StorageUse\\\":5,\\\"Typ\\\":2,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":2,\\\"Temprature\\\":[{\\\"Time\\\":\\\"2018-01-25T11:36:29\\\",\\\"Temp\\\":18.8,\\\"Sensor\\\":1,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-25T11:36:29\\\",\\\"Temp\\\":20.1,\\\"Sensor\\\":2,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-25T11:36:29\\\",\\\"Temp\\\":20.0,\\\"Sensor\\\":3,\\\"Status\\\":0}],\\\"StorageMethod\\\":2,\\\"CachePendingCount\\\":0},{\\\"Name\\\":\\\"HS200-M-00002\\\",\\\"ID\\\":109,\\\"StorageCapacity\\\":19020,\\\"StorageUse\\\":0,\\\"Typ\\\":19,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":5,\\\"Temprature\\\":[{\\\"Time\\\":\\\"2017-07-21T17:04:12\\\",\\\"Temp\\\":-159.8,\\\"Sensor\\\":1,\\\"Status\\\":0},{\\\"Time\\\":\\\"2017-07-21T17:04:12\\\",\\\"Temp\\\":-63.0,\\\"Sensor\\\":2,\\\"Status\\\":0},{\\\"Time\\\":\\\"2017-07-21T17:04:12\\\",\\\"Temp\\\":-71.6,\\\"Sensor\\\":3,\\\"Status\\\":0}],\\\"StorageMethod\\\":1,\\\"CachePendingCount\\\":0},{\\\"Name\\\":\\\"HS200-L-00001\\\",\\\"ID\\\":134,\\\"StorageCapacity\\\":19116,\\\"StorageUse\\\":10,\\\"Typ\\\":19,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":1,\\\"Temprature\\\":[{\\\"Time\\\":\\\"2018-02-09T11:18:43\\\",\\\"Temp\\\":-155.0,\\\"Sensor\\\":1,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-02-09T11:18:43\\\",\\\"Temp\\\":-135.0,\\\"Sensor\\\":2,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-03-14T14:16:36\\\",\\\"Temp\\\":-150.0,\\\"Sensor\\\":3,\\\"Status\\\":0}],\\\"StorageMethod\\\":1,\\\"CachePendingCount\\\":10},{\\\"Name\\\":\\\"HS200M_PT1\\\",\\\"ID\\\":169,\\\"StorageCapacity\\\":37420,\\\"StorageUse\\\":3,\\\"Typ\\\":19,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":2,\\\"Temprature\\\":[{\\\"Time\\\":\\\"2018-01-25T11:23:24\\\",\\\"Temp\\\":-156.8,\\\"Sensor\\\":1,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-25T11:23:24\\\",\\\"Temp\\\":-61.3,\\\"Sensor\\\":2,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-25T11:23:24\\\",\\\"Temp\\\":-107.1,\\\"Sensor\\\":3,\\\"Status\\\":0}],\\\"StorageMethod\\\":1,\\\"CachePendingCount\\\":0},{\\\"Name\\\":\\\"HS200M_SN003\\\",\\\"ID\\\":237,\\\"StorageCapacity\\\":11396,\\\"StorageUse\\\":0,\\\"Typ\\\":19,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":2,\\\"Temprature\\\":[{\\\"Time\\\":\\\"2018-01-25T11:37:55\\\",\\\"Temp\\\":-172.5,\\\"Sensor\\\":1,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-25T11:37:55\\\",\\\"Temp\\\":-120.3,\\\"Sensor\\\":2,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-25T11:37:55\\\",\\\"Temp\\\":-129.9,\\\"Sensor\\\":3,\\\"Status\\\":0}],\\\"StorageMethod\\\":1,\\\"CachePendingCount\\\":0},{\\\"Name\\\":\\\"HS200M_SN004\\\",\\\"ID\\\":1413,\\\"StorageCapacity\\\":118875,\\\"StorageUse\\\":0,\\\"Typ\\\":19,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":4,\\\"Temprature\\\":[{\\\"Time\\\":\\\"2018-01-16T14:43:08\\\",\\\"Temp\\\":850.0,\\\"Sensor\\\":1,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-16T14:43:08\\\",\\\"Temp\\\":20.7,\\\"Sensor\\\":2,\\\"Status\\\":0},{\\\"Time\\\":\\\"2018-01-16T14:43:08\\\",\\\"Temp\\\":21.1,\\\"Sensor\\\":3,\\\"Status\\\":0}],\\\"StorageMethod\\\":1,\\\"CachePendingCount\\\":0},{\\\"Name\\\":\\\"HS200M_REFERENZ\\\",\\\"ID\\\":1753,\\\"StorageCapacity\\\":41814,\\\"StorageUse\\\":0,\\\"Typ\\\":19,\\\"Connection\\\":false,\\\"Priority\\\":true,\\\"Succession\\\":6,\\\"Temprature\\\":[{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0},{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0},{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0}],\\\"StorageMethod\\\":1,\\\"CachePendingCount\\\":3},{\\\"Name\\\":\\\"AWB-00001\\\",\\\"ID\\\":1667,\\\"StorageCapacity\\\":0,\\\"StorageUse\\\":0,\\\"Typ\\\":23,\\\"Connection\\\":false,\\\"Priority\\\":false,\\\"Succession\\\":0,\\\"Temprature\\\":[{\\\"Time\\\":\\\"0001-01-01T00:00:00\\\",\\\"Temp\\\":0.0,\\\"Sensor\\\":0,\\\"Status\\\":0}],\\\"StorageMethod\\\":0,\\\"CachePendingCount\\\":2}],\\\"m_MsgType\\\":9,\\\"m_MsgID\\\":0,\\\"Token\\\":{\\\"TokenType\\\":0},\\\"m_ErrorCode\\\":0,\\\"m_ErrorMessage\\\":\\\"\\\"}\"";
            json = Regex.Unescape(json);
            json = json.Remove(0, 1);
            json = json.Remove(json.Length-1, 1);


            string test = "{\"m_oDeviceInformationList\":[{\"Name\":\"Template HS200 Vial 9mm\",\"ID\":425,\"StorageCapacity\":19572,\"StorageUse\":0,\"Typ\":2,\"Connection\":false,\"Priority\":false,\"Succession\":0,\"Temprature\":[{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0}],\"StorageMethod\":0,\"CachePendingCount\":0},{\"Name\":\"HS200_03028\",\"ID\":1332,\"StorageCapacity\":1634,\"StorageUse\":5,\"Typ\":2,\"Connection\":false,\"Priority\":true,\"Succession\":2,\"Temprature\":[{\"Time\":\"2018-01-25T11:36:29\",\"Temp\":18.8,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-25T11:36:29\",\"Temp\":20.1,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-25T11:36:29\",\"Temp\":20.0,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":2,\"CachePendingCount\":0},{\"Name\":\"HS200-M-00002\",\"ID\":109,\"StorageCapacity\":19020,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":5,\"Temprature\":[{\"Time\":\"2017-07-21T17:04:12\",\"Temp\":-159.8,\"Sensor\":1,\"Status\":0},{\"Time\":\"2017-07-21T17:04:12\",\"Temp\":-63.0,\"Sensor\":2,\"Status\":0},{\"Time\":\"2017-07-21T17:04:12\",\"Temp\":-71.6,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200-L-00001\",\"ID\":134,\"StorageCapacity\":19116,\"StorageUse\":10,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":1,\"Temprature\":[{\"Time\":\"2018-02-09T11:18:43\",\"Temp\":-155.0,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-02-09T11:18:43\",\"Temp\":-135.0,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-03-14T14:16:36\",\"Temp\":-150.0,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":10},{\"Name\":\"HS200M_PT1\",\"ID\":169,\"StorageCapacity\":37420,\"StorageUse\":3,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":2,\"Temprature\":[{\"Time\":\"2018-01-25T11:23:24\",\"Temp\":-156.8,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-25T11:23:24\",\"Temp\":-61.3,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-25T11:23:24\",\"Temp\":-107.1,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200M_SN003\",\"ID\":237,\"StorageCapacity\":11396,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":2,\"Temprature\":[{\"Time\":\"2018-01-25T11:37:55\",\"Temp\":-172.5,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-25T11:37:55\",\"Temp\":-120.3,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-25T11:37:55\",\"Temp\":-129.9,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200M_SN004\",\"ID\":1413,\"StorageCapacity\":118875,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":4,\"Temprature\":[{\"Time\":\"2018-01-16T14:43:08\",\"Temp\":850.0,\"Sensor\":1,\"Status\":0},{\"Time\":\"2018-01-16T14:43:08\",\"Temp\":20.7,\"Sensor\":2,\"Status\":0},{\"Time\":\"2018-01-16T14:43:08\",\"Temp\":21.1,\"Sensor\":3,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":0},{\"Name\":\"HS200M_REFERENZ\",\"ID\":1753,\"StorageCapacity\":41814,\"StorageUse\":0,\"Typ\":19,\"Connection\":false,\"Priority\":true,\"Succession\":6,\"Temprature\":[{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0},{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0}],\"StorageMethod\":1,\"CachePendingCount\":3},{\"Name\":\"AWB-00001\",\"ID\":1667,\"StorageCapacity\":0,\"StorageUse\":0,\"Typ\":23,\"Connection\":false,\"Priority\":false,\"Succession\":0,\"Temprature\":[{\"Time\":\"0001-01-01T00:00:00\",\"Temp\":0.0,\"Sensor\":0,\"Status\":0}],\"StorageMethod\":0,\"CachePendingCount\":2}],\"m_MsgType\":9,\"m_MsgID\":0,\"Token\":{\"TokenType\":0},\"m_ErrorCode\":0,\"m_ErrorMessage\":\"\"}";
            test = test.Replace("\\\"", "\"");
            string text = Regex.Unescape(test);
        }
    }
}