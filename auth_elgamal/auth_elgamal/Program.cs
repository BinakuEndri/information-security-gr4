using auth_elgamal;

Console.WriteLine("=== Day 3: ElGamal sign/verify demo ===\n");

var keyPair = ElGamalKeyGeneration.GenerateKeyPair(512);
Console.WriteLine($"Public key: {keyPair.PublicKey}\n");

var message = "hello from elgamal";
Console.WriteLine($"Message: {message}");

var signature = ElGamalSignatureOps.Sign(message, keyPair);
Console.WriteLine($"Signature: {signature}");

bool valid = ElGamalSignatureOps.Verify(message, signature, keyPair.PublicKey);
Console.WriteLine(valid ? "✓ Verification PASSED" : "✗ Verification FAILED");

var tampered = message + "!";
bool tamperedValid = ElGamalSignatureOps.Verify(tampered, signature, keyPair.PublicKey);
Console.WriteLine(tamperedValid ? "✗ Tampered message incorrectly verified" : "✓ Tampered message correctly rejected");

Console.WriteLine("\n✓ Day 3 complete");
