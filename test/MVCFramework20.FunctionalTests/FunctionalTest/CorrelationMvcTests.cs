﻿namespace MVCFramework20.FunctionalTests.FunctionalTest
{
    using FunctionalTestUtils;
    using Microsoft.ApplicationInsights.DataContracts;
    using System;
    using System.Linq;
    using System.Net.Http;
    using AI;
    using Xunit;
    using Xunit.Abstractions;

    public class CorrelationMvcTests : TelemetryTestsBase
    {
        private const string assemblyName = "MVCFramework20.FunctionalTests";

        public CorrelationMvcTests(ITestOutputHelper output) : base(output)
        {
        }


        [Fact]
        public void CorrelationInfoIsPropagatedToDependendedService()
        {
            using (var server = new InProcessServer(assemblyName, InProcessServer.UseApplicationInsights))
            {
                using (var httpClient = new HttpClient())
                {
                    var task = httpClient.GetAsync(server.BaseHost + "/");
                    task.Wait(TestTimeoutMs);
                }

                var actual = server.Listener.ReceiveItems(2, TestListenerTimeoutInMs);

                var dependencyTelemetry = actual.OfType<TelemetryItem<RemoteDependencyData>>().FirstOrDefault();
                Assert.NotNull(dependencyTelemetry);                         

                var requestTelemetry = actual.OfType<TelemetryItem<RequestData>>().FirstOrDefault();
                Assert.NotNull(requestTelemetry);

                Assert.Equal(requestTelemetry.tags["ai.operation.id"], dependencyTelemetry.tags["ai.operation.id"]);
                Assert.Contains(dependencyTelemetry.tags["ai.operation.id"], requestTelemetry.tags["ai.operation.parentId"]);               
            }
        }
    }
}