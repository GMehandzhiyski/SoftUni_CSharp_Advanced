using System.Text;

namespace MailClient
{
    public class MailBox
    {
		private int capacity;
		private List<Mail> inbox;
		private List<Mail> archive;

        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public int Capacity
        {
			get { return capacity; }
			set { capacity = value; }
		}
		public List<Mail> Inbox
        {
			get { return inbox; }
			set { inbox = value; }
		}
		public List<Mail> Archive
		{
			get { return archive; }
			set { archive = value; }
		}

		public void IncomingMail(Mail mail) 
		{
            if (Inbox.Count < Capacity)
            {
				Inbox.Add(mail);
            }
        }
		public bool DeleteMail(string sender)
		{

			return Inbox.Remove(Inbox.FirstOrDefault(i => i.Sender == sender));
		}

        public int ArchiveInboxMessages()
		{
			foreach (Mail mail in Inbox)
			{
				Archive.Add(mail);
			}
			Inbox.RemoveAll(item=> true);

			return Archive.Count;
		}

		public string GetLongestMessage()
		{
			string longestBody = Inbox.OrderByDescending(i => i.Body).FirstOrDefault().ToString();
			
			return longestBody.ToString();
		}

		public string InboxView()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Inbox:");
			foreach (Mail mail in Inbox)
			{
				sb.AppendLine(mail.ToString().TrimEnd());
			}

			return sb.ToString().TrimEnd();
		}
    }
}
