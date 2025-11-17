namespace VibeProxy.Linux.Services;

internal enum AuthCommand
{
    Claude,
    Codex,
    Gemini,
    Qwen
}

internal readonly record struct AuthCommandResult(bool Success, string Message);
