using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using VoiceChat;

namespace SCP049DualVoice
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get { return "049DualVoice"; } }
        public override string Author { get { return "TwojeImie"; } }
        public override string Version { get { return "1.0.0"; } }

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.VoiceChatting += OnVoiceChatting;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.VoiceChatting -= OnVoiceChatting;
            base.OnDisabled();
        }

        private void OnVoiceChatting(VoiceChattingEventArgs ev)
        {
            if (ev.Player.Role != RoleTypeId.Scp049)
                return;

            // V = normalny lokalny głos
            if (ev.VoiceChannel == VoiceChatChannel.Proximity)
                return;

            // Q = SCP Chat
            if (ev.VoiceChannel == VoiceChatChannel.ScpChat)
                return;
        }
    }
}
