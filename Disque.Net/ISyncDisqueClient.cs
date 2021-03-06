﻿using System.Collections.Generic;

namespace Disque.Net
{
    public interface ISyncDisqueClient
    {
        string AddJob(string queueName, string job, int mstimeout);
        string AddJob(string queueName, string job, long mstimeout, JobParams jobParams);
        List<Job> GetJob(List<string> queueNames);
        List<Job> GetJob(params string[] queues);
        List<Job> GetJob(long timeout, long count, List<string> queueNames);
        List<Job> GetJob(long timeout, long count, params string[] queues);
        long Ackjob(List<string> jobIdList);
        long Ackjob(params string[] jobIds);
        string Info();
        string Info(string section);
        long Qlen(string queueName);
        List<Job> Qpeek(string queueName, long count);
        long DelJob(string jobId);
        long Dequeue(List<string> jobIdList);
        long Dequeue(params string[] jobIds);
        long Enqueue(List<string> jobIdList);
        long Enqueue(params string[] jobIds);
        long Fastack(List<string> jobIdList);
        long Fastack(params string[] jobIds);
        JobInfo Show(string jobId);
        string Ping();
        long Working(string jobId);
        void Close();
    }
}