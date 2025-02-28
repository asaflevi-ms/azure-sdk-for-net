// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI;

// CUSTOM CODE NOTE:
// Suppress the parameterized constructor that only receives the audio data in favor of a custom
// parameterized constructor that receives the deployment name as well.
[CodeGenSuppress("AudioTranscriptionOptions", typeof(BinaryData))]
public partial class AudioTranscriptionOptions
{
    // CUSTOM CODE NOTE:
    // Add a setter to this required property to allow for an "init" pattern when using the public
    // default constructor.

    /// <summary>
    /// The audio data to transcribe. This must be the binary content of a file in one of the supported media formats:
    /// flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, webm.
    /// <para>
    /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
    /// The byte[] will be serialized to a Base64 encoded string.
    /// </para>
    /// <para>
    /// Examples:
    /// <list type="bullet">
    /// <item>
    /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
    /// <description>Creates a payload of "AQID".</description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    public BinaryData AudioData { get; set; }

    // CUSTOM CODE NOTE:
    // Add custom doc comment.

    /// <summary>
    /// The deployment name to use for audio transcription.
    /// </summary>
    /// <remarks>
    /// <para>
    /// When making a request against Azure OpenAI, this should be the customizable name of the "model deployment"
    /// (example: my-gpt4-deployment) and not the name of the model itself (example: gpt-4).
    /// </para>
    /// <para>
    /// When using non-Azure OpenAI, this corresponds to "model" in the request options and should use the
    /// appropriate name of the model (example: gpt-4).
    /// </para>
    /// </remarks>
    public string DeploymentName { get; set; }

    // CUSTOM CODE NOTE:
    // Add a parameterized constructor that receives the deployment name as a parameter in addition
    // to the other required properties.

    /// <summary> Initializes a new instance of <see cref="AudioTranscriptionOptions"/>. </summary>
    /// <param name="deploymentName"> The deployment name to use for audio transcription. </param>
    /// <param name="audioData">
    /// The audio data to transcribe.This must be the binary content of a file in one of the supported media formats:
    /// flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, webm.
    /// </param>
    /// <remarks>
    /// By default, audio data will be provided as if it were from an audio file named "file.wav". For other audio
    /// formats, set an appropriate filename via the <see cref="Filename"/> property such that the format can be
    /// inferred. For example, setting <see cref="Filename"/> to "foo.mp3" for an MP3 stream will ensure that the
    /// audio data is handled as MP3 input.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    ///     <paramref name="deploymentName"/> or <paramref name="audioData"/> is null.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     <paramref name="deploymentName"/> is an empty string.
    /// </exception>
    public AudioTranscriptionOptions(string deploymentName, BinaryData audioData)
    {
        Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
        Argument.AssertNotNull(audioData, nameof(audioData));

        DeploymentName = deploymentName;
        AudioData = audioData;
    }

    // CUSTOM CODE NOTE:
    // Add a public default constructor to allow for an "init" pattern using property setters.

    /// <summary> Initializes a new instance of <see cref="AudioTranscriptionOptions"/>. </summary>
    public AudioTranscriptionOptions()
    { }
}
