


namespace Albo1125.Common.CommonLibrary
{
    /// <summary>
    /// Provides extension methods for LSPDFR-related functionality.
    /// </summary>
    public static class ExtensionMethodsLSPDFR
    {
        /// <summary>
        /// Clones a <see cref="Ped"/> and optionally clones its persona.
        /// </summary>
        /// <param name="oldped">The original <see cref="Ped"/> to clone.</param>
        /// <param name="ClonePersona">Whether to clone the persona of the <see cref="Ped"/>.</param>
        /// <returns>A new <see cref="Ped"/> instance cloned from the original.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="oldped"/> is null.</exception>
        public static Ped ClonePed(this Ped oldped, bool ClonePersona)
        {
            if (oldped == null)
                throw new ArgumentNullException(nameof(oldped), "The Ped to clone cannot be null.");

            Ped newPed = oldped.ClonePed();

            if (ClonePersona)
            {
                Persona oldPersona = Functions.GetPersonaForPed(oldped);
                Functions.SetPersonaForPed(newPed, oldPersona);
            }

            return newPed;
        }
    }
}
