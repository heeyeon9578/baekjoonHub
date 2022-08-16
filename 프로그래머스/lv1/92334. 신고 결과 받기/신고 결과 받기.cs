using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{

    public int[] solution(string[] id_list, string[] report, int k)
    {

        //신고한 아이디들을 신고자 id에 저장;
        Dictionary<string, List<string>> reportedIds = new Dictionary<string, List<string>>();
        //신고당한 횟수를 id에 저장
        Dictionary<string, int> reportedCount = new Dictionary<string, int>();

        //중복 신고 제거
        report = report.Distinct().ToArray();

        //필요한 자료를 구한다
        for (int i = 0; i < report.Length; i++)
        {
            string[] reportSplit = report[i].Split(' ');
            string reportId = reportSplit[0];
            string reportedId = reportSplit[1];

            //신고한 사람 추가하기
            if (reportedIds.ContainsKey(reportId))
                reportedIds[reportId].Add(reportedId);
            else
                reportedIds.Add(reportId, new List<string> { reportedId });

            //신고당한 횟수 추가하기
            if (reportedCount.ContainsKey(reportedId))
                reportedCount[reportedId]++;
            else
                reportedCount.Add(reportedId, 1);
        }


        //answer를 리스트로 받아온다.        
        List<int> answerList = new List<int>();

        for (int i = 0; i < id_list.Length; i++)
        {
            int sendCount = 0;

            //신고한 적이 있는지 확인한다
            if (reportedIds.ContainsKey(id_list[i]))
            {
                for (int j = 0; j < reportedIds[id_list[i]].Count; j++)
                {
                    //만약 신고당함 리스트에 id가 있고, k번 이상 신고당했으면 카운트한다.
                    string reportedId = reportedIds[id_list[i]][j];
                    if (reportedCount.ContainsKey(reportedId))
                    {
                        if (reportedCount[reportedId] >= k)
                        {
                            sendCount++;
                        }
                    }
                }
            }

            //신고처리과 완료된 카운트를 저장한다.
            answerList.Add(sendCount);
        }

        int[] answer = answerList.ToArray();

        return answer;
    }
}